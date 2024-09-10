using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using SampleApp.Attribute;
using SampleApp.Converters;
using SampleApp.Models.Bases;
using SampleApp.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleApp.ViewModels
{
    public class MainWindowViewModel : ModelBase
    {
        public ReactiveCommand TestCommand { get; set; }
        public string Text { get; set; }

        public MainWindowViewModel()
        {
            TestCommand = new ReactiveCommand().WithSubscribe(() =>
            {
                Text = string.IsNullOrEmpty(Text) ? "Hello, world!" : "";
            }).AddTo(disposables);
        }
    }
}
