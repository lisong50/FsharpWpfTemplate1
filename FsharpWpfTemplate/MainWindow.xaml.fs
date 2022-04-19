namespace FsharpWpfTemplate

open System.Windows
open FsharpWpfTemplate.ViewModels

module MainWindow =
  let initialize (window: Window) =
    window.DataContext <- MainWindowViewModel()
    ()
