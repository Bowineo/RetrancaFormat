using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RetrancaFormat
{
    public partial class RetrancaFormat : Form
    {
        public RetrancaFormat()
        { InitializeComponent(); }
        public bool PrimeiroChar = true;

        private void BtnEscolhePath_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbPathEscolhido.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.LastPath = tbPathEscolhido.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void BtnGravarArquivo_Click(object sender, EventArgs e)
        {
            Gravar(Concatenar(GetNomes(tbInputTexto.Text), tbPrefixo.Text, tbSufixo.Text), tbPathEscolhido.Text);
        }

        private void TbInputTexto_DoubleClick(object sender, EventArgs e)
        {
            if (tbInputTexto.Text != "" && tbInputTexto.Text.Trim().Length > 0)
            {
                tbInputTexto.Text = RemoveLinhas(GetNomes(tbInputTexto.Text), tbInputTexto.SelectedText);
            }

        }

        private void TbInputTexto_TextChanged(object sender, EventArgs e)
        {
            if (tbInputTexto.Text != "" && tbInputTexto.Text.Trim().Length > 0)
            {
                tbInputTexto.Text = RemoveLinhas(ReitarItensListados(GetNomes(tbInputTexto.Text), Properties.Settings.Default.ListaRetirar), tbInputTexto.SelectedText);

                if (LinhaTexto(GetNomes(tbInputTexto.Text), tbInputTexto.SelectedText).EndsWith("_") && !PrimeiroChar)
                { tbInputTexto.Select(tbInputTexto.Text.Trim().Length, 0); }

                btnGravarArquivo.Enabled = true;
            }
            else { btnGravarArquivo.Enabled = false; }
            if (PrimeiroChar && tbInputTexto.Text.Trim().Length <= 1)
            {
                tbInputTexto.Select(tbInputTexto.Text.Trim().Length, 0);
                PrimeiroChar = false;
            }
            if (tbInputTexto.Text == "") { PrimeiroChar = true; }
        }

        private void RetrancaFormat_Load(object sender, EventArgs e)
        {
            tbPathEscolhido.Text = Properties.Settings.Default.LastPath;
            TbListaRetirar.Text = ArrayToString(Properties.Settings.Default.ListaRetirar);
            GetNomeProduto();
        }

        private void BtnAdicionaListaRetirar_Click(object sender, EventArgs e)
        {
            System.Collections.Specialized.StringCollection colecao = new System.Collections.Specialized.StringCollection();
            colecao.AddRange(GetNome(TbListaRetirar.Text));
            Properties.Settings.Default.ListaRetirar = colecao;
            Properties.Settings.Default.Save();
            TbListaRetirar.Text = ArrayToString(Properties.Settings.Default.ListaRetirar);
            DialogResult result = MessageBox.Show("A lista de exclusão foi salva.");
            if (result == DialogResult.OK)
            {
                tbInputTexto.Text = RemoveLinhas(ReitarItensListados(GetNomes(tbInputTexto.Text), Properties.Settings.Default.ListaRetirar), tbInputTexto.SelectedText);
                Expandir();
            }
        }

        private void BtnExpande_Click(object sender, EventArgs e)
        { Expandir(); }

        public void Expandir()
        {
            if (btnExpande.Text == "<") { btnExpande.Text = ">"; Form.ActiveForm.Size = new Size(520, 604); }
            else { btnExpande.Text = "<"; Form.ActiveForm.Size = new Size(390, 604); }
        }

        public static string[] ReitarItensListados(string[] entrada, System.Collections.Specialized.StringCollection ListaRetirar)
        {
            for (int j = 0; j < ListaRetirar.Count; j++)
            {
                for (int i = 0; i < entrada.Length; i++)
                {
                    int tamanhoEntrada = entrada[i].Length;
                    if (!((tamanhoEntrada - ListaRetirar[j].Length) <= 0) && entrada[i].ToUpper().EndsWith(ListaRetirar[j]))
                    {
                        entrada[i] = entrada[i].Substring(0, entrada[i].Length - ListaRetirar[j].Length);
                    }
                }
            }
            return entrada;
        }

        public string ArrayToString(string[] entrada)
        {
            string saida = "";
            for (int i = 0; i < entrada.Length; i++)
            { saida += entrada[i] + Environment.NewLine; }
            return saida;
        }

        public string ArrayToString(System.Collections.Specialized.StringCollection entrada)
        {
            string saida = "";
            for (int i = 0; i < entrada.Count; i++)
            { saida += entrada[i] + Environment.NewLine; }
            return saida;
        }

        public string[] GetNomes(string entrada)
        {
            string[] str = entrada.Split('\r');
            for (int i = 0; i < str.Length; i++)
            { str[i] = RemoveSpecialCharacters(str[i].Replace("\n", "")); }
            str = RetiraNomesInicio(str);
            str = SeparaBlocos(str);
            return str;
        }

        public string[] GetNome(string entrada)
        {
            string[] str = entrada.ToUpper().Split('\r');
            for (int i = 0; i < str.Length; i++)
            { str[i] = RemoveSpecialCharacters(str[i].Replace("\n", "")); }
            return str;
        }

        public string[] Concatenar(string[] entrada, string prefixo, string sufixo)
        {
            string[] str = entrada;
            if (prefixo != "" && sufixo == "")
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] != "")
                    {
                        if (str[i].ToUpper().Contains("BLOCO")) { str[i] = str[i]; }
                        else { str[i] = (prefixo + "_" + str[i]); }
                    }
                }
            }
            if (sufixo != "" && prefixo == "")
            {
                for (int i = 0; i < str.Length; i++)
                {

                    if (str[i] != "")
                    {
                        if (str[i].ToUpper().Contains("BLOCO"))
                        {
                            str[i] = str[i];
                        }
                        else
                        {
                            str[i] = (str[i] + "_" + sufixo);
                        }


                    }
                }
            }
            if (sufixo != "" && prefixo != "")
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] != "")
                    {
                        if (str[i].ToUpper().Contains("BLOCO"))
                        {
                            str[i] = str[i];
                        }
                        else
                        {
                            str[i] = (prefixo + "_" + str[i] + "_" + sufixo);
                        }
                    }
                }
            }
            return str;
        }

        public void Gravar(string[] TextoGravar, string PathSaida)
        {
            string fileName = PathSaida + @"\Retrancas.txt";
            try
            {
                if (tbPathEscolhido.Text != "" && TextoGravar.Length != 0 && tbPathEscolhido.Text != @"C:\")
                {
                    TextoGravar = RetiraUnderlineFinal(RetiraLinhasVazias(TextoGravar));
                    using (StreamWriter strW = new StreamWriter(fileName, false))
                    {
                        foreach (string linha in TextoGravar)
                        { strW.Write(ReduzUnderline(linha) + "\r\n"); }
                        strW.Close();
                        MessageBox.Show("Concluído!");
                        tbInputTexto.Text = "";
                        btnGravarArquivo.Enabled = false;
                        tbSufixo.Text = "";
                        GetNomeProduto();
                        tbInputTexto.Select();
                    }
                }
                else
                {
                    if (tbPathEscolhido.Text == @"C:\")
                    {
                        MessageBox.Show("Defina outro caminho para salvar o arquivo!");
                        btnEscolhePath.Focus();
                    }
                    else { MessageBox.Show("Input de texto está vazio!"); }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao gravar arquivo" + e.ToString());
            }
        }

        public string LinhaTexto(string[] entrada, string select)
        {
            String[] linhas = entrada;
            System.Collections.ArrayList lista = new System.Collections.ArrayList(linhas);
            return linhas[lista.IndexOf(select)];
        }


        public string RemoveLinhas(string[] lines, string TextSelecionado)
        {
            String[] linhas = lines;
            System.Collections.ArrayList lista = new System.Collections.ArrayList(linhas);
            if (0 <= lista.IndexOf(TextSelecionado))
            {
                lista.RemoveAt(lista.IndexOf(TextSelecionado));
                linhas = (System.String[])lista.ToArray(Type.GetType("System.String"));
                return ArrayToString(linhas);
            }
            else { return ArrayToString(linhas); }
        }

        public void GetNomeProduto()
        {
            string produto = "";
            int hora = DateTime.Now.Hour;
            if (hora <= 9 || hora >= 21) { produto = "EPTV_CP_BDC"; }
            if (hora > 9 && hora <= 14) { produto = "EPTV_CP_JE1"; }
            if (hora > 14 && hora < 21) { produto = "EPTV_CP_JE2"; }
            tbPrefixo.Text = produto + DateTime.Now.ToString("_dd_MM");
        }

        public string RemoveSpecialCharacters(string text)
        {
            string ret;
            text = text.Replace("/", "_").Replace("-", "_").Replace("+", "_").Replace("(", "_").Replace(")", "_").Replace("_", " ");
            ret = System.Text.RegularExpressions.Regex.Replace(text, @"[^0-9a-zA-ZéúíóáÉÚÍÓÁèùìòàÈÙÌÒÀõãñÕÃÑêûîôâÊÛÎÔÂëÿüïöäËYÜÏÖÄçÇ\s]+?", string.Empty);
            ret = ReduzUnderline(RemoverAcentos(ret.Replace(" ", "_")));
            return ret;
        }

        public static string RemoverAcentos(string texto)
        {
            string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";
            for (int i = 0; i < comAcentos.Length; i++)
            { texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString()); }
            return texto;
        }

        public static string[] SeparaBlocos(string[] texto)
        {
            int NumeroBloco = 1;
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i].ToUpper().Contains("COMERCIAL") || texto[i].ToUpper().Contains("BLOCO"))
                {
                    NumeroBloco++;
                    texto[i] = "BLOCO" + "_" + NumeroBloco.ToString();
                }
            }
            return texto;
        }

        public static string ReduzUnderline(string texto)
        {
            while (texto.Contains("__"))
            {
                texto = texto.Replace("__", "_");
            }
            return texto;
        }

        public static string[] RetiraUnderlineFinal(string[] entrada)
        {
            for (int i = 0; i < entrada.Length; i++)
            {
                while (entrada[i].EndsWith("_"))
                {
                    entrada[i] = entrada[i].Substring(0, entrada[i].Length - 1);
                }
                while (entrada[i].StartsWith("_"))
                {
                    entrada[i] = entrada[i].Substring(1, entrada[i].Length - 1);
                }
            }
            return entrada;
        }

        public static string[] RetiraNomesInicio(string[] entrada)
        {

            for (int i = 0; i < entrada.Length; i++)
            {
                if (entrada[i].Length >= 4)
                {
                    if (entrada[i].Substring(0, 3) == "PE_" || entrada[i].Substring(0, 4) == "PASS" || entrada[i].Substring(0, 4) == "OSVA")
                    {
                        entrada[i] = "";
                    }
                    if (entrada[i].Length >= 7 && (entrada[i].Substring(0, 7) == "OSVALDO" || entrada[i].Substring(0, 7) == "ESPORTE" || entrada[i].Substring(0, 7) == "VINHETA"))
                    {
                        entrada[i] = "";
                    }
                }

            }
            return entrada;

        }

        public static string[] RetiraLinhasVazias(string[] entrada)
        {
            List<string> lista = new List<string>();
            for (int i = 0; i < entrada.Length; i++)
            {
                if (entrada[i] != "") { lista.Add(entrada[i]); }
            }
            return lista.ToArray();
        }
    }


}
