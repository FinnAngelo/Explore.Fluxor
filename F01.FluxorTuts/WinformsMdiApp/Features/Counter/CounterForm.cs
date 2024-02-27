using AutoMapper;
using Explore.Fluxor.FluxorTuts.Features.Counter;
using Fluxor;

namespace Explore.Fluxor.FluxorTuts.WinformsApp.Features.Counter;
public partial class CounterForm : Form
{
    private readonly IDispatcher _dispatcher;
    private readonly IState<CounterState> _counterState;
    private readonly IMapper _mapper;

    public CounterForm(
        IDispatcher dispatcher,
        IState<CounterState> counterState,
        IMapper mapper
        )
    {
        _dispatcher = dispatcher;
        _counterState = counterState;
        _mapper = mapper;

        InitializeComponent();

        _counterState.StateChanged += CounterState_StateChanged;
        CounterState_StateChanged(this, new());
    }

    private void CounterState_StateChanged(object? sender, EventArgs e)
        => _mapper.Map(_counterState.Value, this);

    private void btnIncrementCount_Click(object sender, EventArgs e)
        => _dispatcher.Dispatch(new CounterIncrementAction());

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CounterState, CounterForm>()
            .ForPath(dest => dest.lblCurrentCount.Text, opt => opt.MapFrom(src => src.CurrentCount));
        }
    }

}