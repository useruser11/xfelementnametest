using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ElementNameTest
{
    public class SimpleTemplateSelector : DataTemplateSelector
    {
        public DataTemplate IsTemplateOne { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return IsTemplateOne;
        }
    }
}
