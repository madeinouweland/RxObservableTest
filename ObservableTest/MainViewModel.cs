namespace ObservableTest
{
    public class MainViewModel : ObservableObject
    {
        public EditProp<string> Name { get; set; }
        public EditProp<string> Address { get; set; }
        public ComputedProp<string> Computed { get; set; }

        public MainViewModel()
        {
            Name = new EditProp<string>();
            Address = new EditProp<string>();

            Computed = new ComputedProp<string>();
            Computed.ComputeOn(Name);
            Computed.ComputeOn(Address);

            Computed.Computation = () => Name.Value + "+" + Address.Value;

            Name.Value = "A";
            Address.Value = "B";
        }
    }
}
