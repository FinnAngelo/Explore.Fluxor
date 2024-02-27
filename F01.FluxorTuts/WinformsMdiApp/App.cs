using AutoMapper;
using Explore.Fluxor.FluxorTuts.Features.Counter;
using Explore.Fluxor.FluxorTuts.WinformsApp.Features.Counter;
using Fluxor;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace Explore.Fluxor.FluxorTuts.WinformsApp;

public partial class App : Form
{
    private readonly IState<CounterState> _counterState;
    public readonly IMapper _mapper;

    public App(
        IState<CounterState> counterState,
        IMapper mapper
        )
    {
        _counterState = counterState;
        _mapper = mapper;

        InitializeComponent();

        counterToolStripMenuItem.Click += counterToolStripMenuItem_Click;
        _counterState.StateChanged += (s,e) => _mapper.Map(_counterState.Value, this);

    }

    CounterForm? _counterForm;

    private void counterToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        // Do this for a 'singleton-ish' window
        _counterForm = _counterForm.MdiShow(mdiParent: this);

        // Do this to have multiple windows
        // Program.ServiceProvider.GetRequiredService<CounterForm>().MdiShow(mdiParent: this);
    }

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CounterState, App>()
            .ForPath(
                dest => dest.counterToolStripMenuItem.Text,
                opt => opt.MapFrom(src => $@"&Counter ({src.CurrentCount})")
                );
        }
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
