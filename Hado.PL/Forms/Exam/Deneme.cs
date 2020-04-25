using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wordeaktar = Microsoft.Office.Interop.Word;

namespace Hado.PL.Forms.Exam
{
    public partial class Deneme : Form
    {
        public Deneme()
        {
            InitializeComponent();
        }

        private void Deneme_Load(object sender, EventArgs e)
        {

        }

        //Find and Replace Method
        private void FindAndReplace(Microsoft.Office.Interop.Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }

        //Create the Doc Method
        private void CreateWordDocument(object filename, object SaveAs)
        {
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            object missing = Missing.Value;
            Microsoft.Office.Interop.Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace
                this.FindAndReplace(wordApp, "<school>", textBox1.Text);
                this.FindAndReplace(wordApp, "<Fyear>", DateTime.Now.Year-1);
                this.FindAndReplace(wordApp, "<Syear>", DateTime.Now.Year);
                this.FindAndReplace(wordApp, "<year>", DateTime.Now.ToShortDateString());
                this.FindAndReplace(wordApp, "<Season>", "2");
                this.FindAndReplace(wordApp, "<Program>", "Bilgisayar");
                for (int i = 1; i <= 10; i++)
                {
                    this.FindAndReplace(wordApp, "<soru"+i+">", "BURALAR SORU OLACAKKK AĞA YAPTIIM");
                }
                for (int i = 1; i <= 10; i++)
                {
                    this.FindAndReplace(wordApp, "<cevap" + i + ">", "A)Falan Filan B)Falan Filan C)Falan Filan D)Falan Filan");
                }
            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Created!");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           CreateWordDocument(@"C:\Projects\HadoSystem\Hado.PL\Resources\SinavKagidi.docx", @"C:\Users\hakan\Desktop\SinavKagidi.docx");
        }
    }
}
