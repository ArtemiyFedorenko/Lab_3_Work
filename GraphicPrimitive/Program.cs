using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        GraphicsEditor editor = new GraphicsEditor();
        Group group = new Group();

        group.AddPrimitive();
        group.Scale(5);
        group.Scale(5, 5);
        group.Move(5, 5);

        editor.AddPrimitive();
        editor.ChangeScale(5);
        editor.DrawFigure();
    }
}