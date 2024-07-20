using DynamicArray;
namespace DynamicArray.Tests
{
    public class IntArrayTests
    {
        [Fact]
        public void Constructor_ShouldInitializeWithGivenCapacity_True()
        {
            int capacity = 10;
            IntArray intArray = new IntArray(capacity);
            Assert.Equal(0, intArray.Length());
            Assert.True(intArray.IsEmpty());
        }
        [Fact]
        public void Length_ShouldIncreaseLength_True()
        {
            IntArray intArray = new IntArray(2);
            intArray.Add(1);
            intArray.Add(2);
            Assert.Equal(2, intArray.Length());
        }
        [Fact]
        public void Set_ShouldSetElementAtIndex_True()
        {
            IntArray intArray = new IntArray(2);
            intArray.Add(1);
            intArray.Set(5, 0);
            Assert.Equal(5, intArray.Get(0));
        }
        [Fact]
        public void AddAt_ShouldInsertElementAtIndex_True()
        {
            IntArray intArray = new IntArray(3);
            intArray.Add(1);
            intArray.Add(2);
            intArray.AddAt(1, 3);
            Assert.Equal(3, intArray.Get(1));
            Assert.Equal(2, intArray.Get(2));
            Assert.Equal(3, intArray.Length());
        }

        [Fact]
        public void Remove_ShouldDecreaseLength_True()
        {
            IntArray intArray = new IntArray(4);
            intArray.Add(1);
            intArray.Add(2);
            intArray.Add(3);
            intArray.Add(4);
            intArray.Remove();
            intArray.Remove();
            Assert.Equal(2, intArray.Length());
        }

        [Fact]
        public void RemoveAt_ShouldRemoveElementAtIndex_True()
        {
            IntArray intArray = new IntArray(3);
            intArray.Add(1);
            intArray.Add(2);
            intArray.Add(3);
            intArray.RemoveAt(1);
            Assert.Equal(3, intArray.Get(1));
            Assert.Equal(2, intArray.Length());
        }

        [Fact]
        public void ShrinkSize_ShouldReduceCapacityToLength_True()
        {
            IntArray intArray = new IntArray(4);
            intArray.Add(1);
            intArray.Add(2);
            intArray.ShrinkSize();
            Assert.Equal(2, intArray.Length());
        }
    }
}