using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace Xamarin.Forms.BehaviorsPack.Tests
{
    public class DummyPlatformServices : IPlatformServices
    {
        [System.Runtime.CompilerServices.ModuleInitializer]
        public static void InitializerModule()
        {
            Device.PlatformServices = new DummyPlatformServices();
        }

        public void BeginInvokeOnMainThread(Action action)
        {
            throw new NotImplementedException();
        }

        public Ticker CreateTicker()
        {
            throw new NotImplementedException();
        }

        public Assembly[] GetAssemblies()
        {
            return new Assembly[0];
        }

        public string GetHash(string input)
        {
            throw new NotImplementedException();
        }

        public string GetMD5Hash(string input)
        {
            throw new NotImplementedException();
        }

        public double GetNamedSize(NamedSize size, Type targetElementType, bool useOldSizes)
        {
            throw new NotImplementedException();
        }

        public Color GetNamedColor(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Stream> GetStreamAsync(Uri uri, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public IIsolatedStorageFile GetUserStoreForApplication()
        {
            throw new NotImplementedException();
        }

        public void OpenUriAction(Uri uri)
        {
            throw new NotImplementedException();
        }

        public void StartTimer(TimeSpan interval, Func<bool> callback)
        {
            throw new NotImplementedException();
        }

        public void QuitApplication()
        {
            throw new NotImplementedException();
        }

        public SizeRequest GetNativeSize(VisualElement view, double widthConstraint, double heightConstraint)
        {
            throw new NotImplementedException();
        }

        public bool IsInvokeRequired { get; }
        public OSAppTheme RequestedTheme { get; }
        public string RuntimePlatform { get; }
    }
}