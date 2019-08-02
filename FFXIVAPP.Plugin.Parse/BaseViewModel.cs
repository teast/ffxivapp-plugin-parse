using System.Runtime.CompilerServices;
using ReactiveUI;

namespace FFXIVAPP.Plugin.Parse {
    public class BaseViewModel: ReactiveObject {
        protected void OnPropertyChanged(string propertyName) {
            this.RaisePropertyChanged(propertyName);
        } 

        protected void RaisePropertyChanged([CallerMemberName] string caller = "") {
                IReactiveObjectExtensions.RaisePropertyChanged(this, caller);
        }
    }
}