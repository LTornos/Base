
namespace Base.Lab.NUnitTesting.ClassesToTest
{
    public class ClassOne
    {
        public ClassOne(object objectPassed)
        {
            if (objectPassed == null)
                throw new NotObjectPassedException();
        }
        public bool MethodOne(object objectPassed)
        {
            if (objectPassed == null)
                throw new NotObjectPassedException();


            if (objectPassed is string )
                return false;

            return true;
        }

    }
}
