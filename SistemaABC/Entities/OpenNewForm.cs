using System.Windows.Forms;

namespace SistemaABC.Entities
{
    public class OpenNewForm
    {
        public void AbrirFormEnPanel(object Formulario, Panel frm)
        {
            if (frm.Controls.Count > 0)
                frm.Controls.RemoveAt(0);
            Form fh = Formulario as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            frm.Controls.Add(fh);
            frm.Tag = fh;
            fh.Show();
        }

    }
}
