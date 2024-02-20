using Explore.Fluxor.FluxorTuts.WinformsApp.Features.Counter;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace Explore.Fluxor.FluxorTuts.WinformsApp
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        CounterForm? _counterForm;
        private void counterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Do this for a 'singleton-ish' window
            _counterForm = _counterForm.MdiShow(mdiParent: this);

            // Do this to have multiple windows
            // Program.ServiceProvider.GetRequiredService<CounterForm>().MdiShow(mdiParent: this);
        }
    }

    file static class Extensions
    {
        public static TForm MdiShow<TForm>(this TForm? form, Form mdiParent) where TForm : Form
        {
            if (form == null || form.IsDisposed)
            {
                form = Program.ServiceProvider.GetRequiredService<TForm>();
            }
            form.MdiParent = mdiParent;
            form.Show();
            form.BringToFront();
            return form;
        }
    }
}
