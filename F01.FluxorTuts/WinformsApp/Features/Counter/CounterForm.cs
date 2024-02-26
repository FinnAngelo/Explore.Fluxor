using AutoMapper;
using Explore.Fluxor.FluxorTuts.Features.Counter;
using Fluxor;

namespace Explore.Fluxor.FluxorTuts.WinformsApp.Features.Counter;
public partial class CounterForm : Form
{
    private IDispatcher Dispatcher { get; }
    private IState<CounterState> CounterState { get; }
    private IMapper Mapper { get; }

    public CounterForm(
        IDispatcher dispatcher,
        IState<CounterState> counterState,
        IMapper mapper
        )
    {
        InitializeComponent();
        Dispatcher = dispatcher;
        CounterState = counterState;
        Mapper = mapper;

        CounterState.StateChanged += CounterState_StateChanged;
        CounterState_StateChanged(this, new());
    }

    private void CounterState_StateChanged(object? sender, EventArgs e)
        => Mapper.Map(CounterState.Value, this);

    private void btnIncrementCount_Click(object sender, EventArgs e)
        => Dispatcher.Dispatch(new CounterIncrementAction());

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CounterState, CounterForm>()
            .ForPath(dest => dest.lblCurrentCount.Text, opt => opt.MapFrom(src => src.CurrentCount));
        }
    }

}