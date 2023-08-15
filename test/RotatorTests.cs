using impl;

namespace test;

public class UnitTest1
{
    [Fact]
    public void Rotate3x3()
    {
        var array2d = new int[][]
        {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9}
        };

        var expected = new int[][]
        {
            new int[] {4, 1, 2},
            new int[] {7, 5, 3},
            new int[] {8, 9, 6}
        };

        var sut = new Rotator();
        var actual = sut.Rotate(array2d);

        for (int i = 0; i < actual.Length; i++)
        {
            Assert.Equivalent(expected[i], actual[i]);
        }
    }

    [Fact]
    public void Rotate4x4()
    {
        var array2d = new int[][]
        {
            new int[] {1, 2, 3, 4},
            new int[] {5, 6, 7, 8},
            new int[] {9, 10, 11, 12},
            new int[] {13, 14, 15, 16}
        };

        var expected = new int[][]
        {
            new int[] {5, 1, 2, 3 } ,
            new int[] {9, 10, 6, 4 },
            new int[] {13, 11, 7, 8},
            new int[] {14, 15, 16, 12}
        };

        var sut = new Rotator();
        var actual = sut.Rotate(array2d);

        for (int i = 0; i < actual.Length; i++)
        {
            Assert.Equivalent(expected[i], actual[i]);
        }
    }
}
