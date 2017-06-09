using Xamarin.Forms;

namespace XamarinForms.Behaviors
{
    internal static class ElementExtensions
    {
        internal static Page GetCurrentPage(this Element element)
        {
            while (true)
            {
                if (element == null) return null;

                if (element.Parent is Page page)
                {
                    return page;
                }
                else
                {
                    element = element.Parent;
                }
            }
        }
    }
}
