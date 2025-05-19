using System;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TechNoir.Reactive.Test
{
    [TestFixture]
    public class RefCountSetResetDisposableTests
    {
        [Test, Order(100)]
        public void Actions()
        {
            var test_count     = 0;
            var ref_disposable = new RefCountSetResetDisposable(() => test_count++, () => test_count--);
            Assert.AreEqual(0, test_count);

            var disposable1 = ref_disposable.Set();
            Assert.AreEqual(1, test_count);

            var disposable2 = ref_disposable.Set();
            Assert.AreEqual(1, test_count);

            disposable2.Dispose();
            Assert.AreEqual(1, test_count);

            disposable1.Dispose();
            Assert.AreEqual(0, test_count);

            disposable2.Dispose();
            disposable1.Dispose();
            Assert.AreEqual(0, test_count);
        }

        [Test, Order(200)]
        public void SetNull()
        {
            var test_count     = 0;
            var ref_disposable = new RefCountSetResetDisposable(null, () => test_count--);
            Assert.AreEqual(0, test_count);

            var disposable1 = ref_disposable.Set();
            Assert.AreEqual(0, test_count);

            var disposable2 = ref_disposable.Set();
            Assert.AreEqual(0, test_count);

            disposable2.Dispose();
            Assert.AreEqual(0, test_count);

            disposable1.Dispose();
            Assert.AreEqual(-1, test_count);

            disposable2.Dispose();
            disposable1.Dispose();
            Assert.AreEqual(-1, test_count);
        }

        [Test, Order(200)]
        public void ResetNull()
        {
            var test_count     = 0;
            var ref_disposable = new RefCountSetResetDisposable(() => test_count++, null);
            Assert.AreEqual(0, test_count);

            var disposable1 = ref_disposable.Set();
            Assert.AreEqual(1, test_count);

            var disposable2 = ref_disposable.Set();
            Assert.AreEqual(1, test_count);

            disposable2.Dispose();
            Assert.AreEqual(1, test_count);

            disposable1.Dispose();
            Assert.AreEqual(1, test_count);

            disposable2.Dispose();
            disposable1.Dispose();
            Assert.AreEqual(1, test_count);
        }

        [Test, Order(300)]
        public void SetAfterDelay()
        {
            var set_count      = 0;
            var reset_count    = 0;
            var first_delay    = TimeSpan.FromMilliseconds(100);
            var ref_disposable = new RefCountSetResetDisposable(() => set_count++, () => reset_count++, first_delay);
            Assert.AreEqual(0, set_count);
            Assert.AreEqual(0, reset_count);
            
            var disposable1 = ref_disposable.Set();
            Assert.AreEqual(0, set_count);
            Assert.AreEqual(0, reset_count);
            Thread.Sleep(first_delay.Add(first_delay));
            Assert.AreEqual(1, set_count);
            Assert.AreEqual(0, reset_count);
            
            var disposable2 = ref_disposable.Set();
            Assert.AreEqual(1, set_count);
            Assert.AreEqual(0, reset_count);
            
            disposable2.Dispose();
            Assert.AreEqual(1, set_count);
            Assert.AreEqual(0, reset_count);

            disposable1.Dispose();
            Assert.AreEqual(1, set_count);
            Assert.AreEqual(1, reset_count);

            disposable2.Dispose();
            disposable1.Dispose();
            Assert.AreEqual(1, set_count);
            Assert.AreEqual(1, reset_count);
        }

        [Test, Order(400)]
        public void DisposeBeforeDelay()
        {
            var set_count      = 0;
            var reset_count    = 0;
            var first_delay    = TimeSpan.FromMilliseconds(100);
            var ref_disposable = new RefCountSetResetDisposable(() => set_count++, () => reset_count++, first_delay);
            Assert.AreEqual(0, set_count);
            Assert.AreEqual(0, reset_count);
            
            var disposable1 = ref_disposable.Set();
            Assert.AreEqual(0, set_count);
            Assert.AreEqual(0, reset_count);
            disposable1.Dispose();
            Assert.AreEqual(0, set_count);
            Assert.AreEqual(0, reset_count);
            
            var disposable2 = ref_disposable.Set();
            Assert.AreEqual(0, set_count);
            Assert.AreEqual(0, reset_count);
            Thread.Sleep(first_delay.Add(first_delay));
            Assert.AreEqual(1, set_count);
            Assert.AreEqual(0, reset_count);
            
            disposable2.Dispose();
            Assert.AreEqual(1, set_count);
            Assert.AreEqual(1, reset_count);
        }
    }
}
