namespace MonkeyFinder.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]    
    //[NotifyPropertyChangedFor(nameof(IsNotBusy))]  //not recognized
    bool isBusy;

    [ObservableProperty]
    string title;

    public bool IsNotBusy => !IsBusy; //will not work
}