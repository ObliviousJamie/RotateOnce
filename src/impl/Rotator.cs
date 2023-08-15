namespace impl;

public class Rotator
{
    public int[][] Rotate(int[][] array2d)
    {
        var numberOfRings = array2d.Length / 2;
        for (var ringCount = 0; ringCount < numberOfRings; ringCount++)
        {
            var lastIndexInRing = ringCount + 1;

            // Copy these as they will be overwritten
            var topLeft = array2d[ringCount][ringCount];
            var topRight = array2d[ringCount][^lastIndexInRing];
            var bottomLeft = array2d[^lastIndexInRing][ringCount];
            var bottomRight = array2d[^lastIndexInRing][^lastIndexInRing];

            for (int i = 0; i < array2d.Length / 2; i++)
            {
                var incrementingIndex = ringCount + i;
                var incrementingNegativeIndex = lastIndexInRing + i;

                // top, replaces rightmost with one on left
                array2d[ringCount][^incrementingNegativeIndex] = array2d[ringCount][^(incrementingNegativeIndex + 1)];

                // bottom, replaces leftmost with one on right
                array2d[^lastIndexInRing][incrementingIndex] = array2d[^lastIndexInRing][incrementingIndex + 1];

                // left, replaces topmost with one from below
                array2d[incrementingIndex][ringCount] = array2d[incrementingIndex + 1][ringCount];

                // right, replaces bottommost with one from above
                array2d[^incrementingNegativeIndex][^lastIndexInRing] = array2d[^(incrementingNegativeIndex + 1)][^lastIndexInRing];
            }

            // Add missing four back in
            // One from top right
            array2d[ringCount + 1][^lastIndexInRing] = topRight;

            // One from bottom left
            array2d[^lastIndexInRing][^(lastIndexInRing + 1)] = bottomRight;

            // One from left bottom
            array2d[^(lastIndexInRing + 1)][ringCount] = bottomLeft;

            // One from top left
            array2d[ringCount][ringCount + 1] = topLeft;
        }

        return array2d;
    }
}
