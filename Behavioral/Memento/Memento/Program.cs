using Memento;

TextEditor editor = new("Hello world!");
CaretakerMemento gerenciador = new();

editor.ShowText();

gerenciador.AddMemento(editor.Save());

editor.Write("Hello");
editor.ShowText();

gerenciador.AddMemento(editor.Save());

editor.Write("World");
editor.ShowText();

gerenciador.AddMemento(editor.Save());

editor.Restore(gerenciador.GetMemento(1));
editor.ShowText();

editor.Restore(gerenciador.GetMemento(0));
editor.ShowText();

Console.WriteLine("End");