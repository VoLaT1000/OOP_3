using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class Non_Fiction:Book
    {
        public string SubjectArea;
        public Non_Fiction()
        {
            this.type = "Non_Fiction";
        }

        public override void ShowInList(DataGridView dgv)
        {
            string cost = Convert.ToString(this.Ruble);
            cost += "p. ";
            cost += Convert.ToString(this.Kopeck);
            cost += "к.";
            dgv.Rows.Add(this.type, this.Name, "", this.Author, "",this.SubjectArea, "", this.NumberOfPages.ToString(), cost);
        }
        public override void ShowForEditEdition(frmAdd frmAdd)
        {
            frmAdd.tbName.Text = this.Name;
            frmAdd.tbNumberOfPages.Text = Convert.ToString(this.NumberOfPages);
            frmAdd.tbCostRubles.Text = Convert.ToString(this.Ruble);
            frmAdd.tbCostKopecks.Text = Convert.ToString(this.Kopeck);
            frmAdd.lblGengre.Text = "Предметная область";
            frmAdd.lblGengre.Visible = true;
            frmAdd.tbGenre.Text = this.SubjectArea;
            frmAdd.tbGenre.Visible = true;
            frmAdd.lblAuthor.Text = "Автор";
            frmAdd.tbAuthor.Text = this.Author;
        }
        public override void Edit(frmAdd frmAdd)
        {
            this.Name = frmAdd.tbName.Text;
            this.Ruble = Convert.ToInt32(frmAdd.tbCostRubles.Text);
            this.Kopeck = Convert.ToInt32(frmAdd.tbCostKopecks.Text);
            this.NumberOfPages = Convert.ToInt32(frmAdd.tbNumberOfPages.Text);
            this.Author = frmAdd.tbAuthor.Text;
            this.SubjectArea = frmAdd.tbGenre.Text;
        }
    }
}
