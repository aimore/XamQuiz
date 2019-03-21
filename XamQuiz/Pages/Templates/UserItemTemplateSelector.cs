using System;

using Xamarin.Forms;

namespace XamQuiz.Pages
{
    public class UserItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate LoggedInTemplate { get; set; }
        public DataTemplate DefaultTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return (string)item == "Xamarin Forms" ? LoggedInTemplate : DefaultTemplate;
        }
    }
}
