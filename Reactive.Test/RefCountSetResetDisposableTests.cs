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
    }
}
