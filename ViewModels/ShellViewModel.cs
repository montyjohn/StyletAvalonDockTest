using AvalonDock.Layout;
using Stylet;
using System.Collections.ObjectModel;

namespace StyletAvalonDockTest.ViewModels
{
    public class ShellViewModel: Screen
    {
        public ObservableCollection<LayoutDocument> Documents { get; set; } = new ObservableCollection<LayoutDocument>();
        public ObservableCollection<LayoutAnchorable> DocumentsAnchorable { get; set; } = new ObservableCollection<LayoutAnchorable>();

        public void NewLayout()
        {
            HelloWorldViewModel vw = new HelloWorldViewModel();
            
            LayoutDocument layout = new LayoutDocument
            {
                Title = "Hello World - New Layout",
                Content = vw
            };

            Documents.Add(layout);
        }

        public void NewLayoutAnchorable()
        {
            HelloWorldViewModel vw = new HelloWorldViewModel();

            LayoutAnchorable layout = new LayoutAnchorable
            {
                Title = "Hello World - New Anchorable Layout",
                Content = vw
            };

            DocumentsAnchorable.Add(layout);
        }
    }
}
