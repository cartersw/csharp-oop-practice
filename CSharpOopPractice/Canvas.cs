using System;

namespace CSharpIntermediate
{
    public class Canvas
    {
        public static void DrawOtherShapes(List<OtherShape> shapes)
        {
            foreach (var otherShape in shapes)
            {
                otherShape.Draw();
            }
        }
    }
}