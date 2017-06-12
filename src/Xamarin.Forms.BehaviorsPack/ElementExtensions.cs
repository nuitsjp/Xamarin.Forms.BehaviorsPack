namespace Xamarin.Forms.BehaviorsPack
{
    public static class ElementExtensions
    {
	    public static Page GetCurrentPage(this Element element)
        {
            while (true)
            {
                if (element == null) return null;

                if (element is Page page)
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
