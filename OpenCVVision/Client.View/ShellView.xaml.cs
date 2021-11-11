﻿namespace Client.View;

[SingleInstanceView]
public partial class ShellView : ReactiveUserControl<ShellViewModel>
{
    public ShellView()
    {
        InitializeComponent();
        SetupBinding();
    }

    private void SetupBinding()
    {
        this.WhenActivated(d =>
        {
            this.OneWayBind(ViewModel, vm => vm.NavigationViewModelSam, v => v.Nagivate.ViewModel).DisposeWith(d);
            this.OneWayBind(ViewModel, vm => vm.ImageVMSam, v => v.ImgViewer.ViewModel).DisposeWith(d);

            this.OneWayBind(ViewModel, vm => vm.OperaVM, v => v.OperaPanel.ViewModel).DisposeWith(d);
        });
    }
}