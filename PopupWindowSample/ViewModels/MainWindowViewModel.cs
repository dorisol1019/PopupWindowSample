using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;

namespace PopupWindowSample.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand PopupCommand { get; }

        public InteractionRequest<Notification> NotificationRequest { get; } = new InteractionRequest<Notification>();
        public MainWindowViewModel()
        {
            PopupCommand = new DelegateCommand(() =>
              {
                  NotificationRequest.Raise(new Notification() { Title = "" });

              });
        }
    }
}
