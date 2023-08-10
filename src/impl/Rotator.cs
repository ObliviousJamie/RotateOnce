namespace impl;

public class Rotator
{
    public int[][] Rotate(int[][] array2d)
    {
        var numberOfRings = array2d.Length / 2;
        for (var ringCount = 0; ringCount < numberOfRings; ringCount++)
        {
            var curTop = 0;
            var curBottom = 0;
            var lastIndex = ringCount + 1;

            for (int i = 0; i < array2d.Length - 1; i++)
            {
                var reverseLength = (array2d.Length - 1) - i;

                // top
                curTop = array2d[ringCount][reverseLength];
                var topLeft = array2d[ringCount][reverseLength - 1];
                array2d[ringCount][reverseLength - 1] = curTop;
                array2d[ringCount][reverseLength] = topLeft;

                // bottom
                curBottom = array2d[^lastIndex][i];
                var bottomRight = array2d[^lastIndex][i + 1];
                array2d[^lastIndex][i + 1] = curBottom;
                array2d[^lastIndex][i] = bottomRight;

                // // TODO skip one index as we don't care about it for the first iteration
                // // TODO this might not work on non 3x3
                if(i == 0)
                    continue;

                // left
                var curLeft = array2d[reverseLength][ringCount];
                var nextLeft = array2d[reverseLength - 1][ringCount];
                array2d[reverseLength - 1][ringCount] = curLeft;
                array2d[reverseLength][ringCount] = nextLeft;

                // right
                var curRight = array2d[i][^lastIndex];
                var nextRight = array2d[i + 1][^lastIndex];
                array2d[i + 1][^lastIndex] = curRight;
                array2d[i][^lastIndex] = nextRight;
            }

            // One from top right
            array2d[ringCount + 1][^lastIndex] = curTop;

            // One from bottom left
            // array2d[^2][0] = curBottom;
            array2d[^(lastIndex+1)][ringCount] = curBottom;
        }

        return array2d;
    }
}
