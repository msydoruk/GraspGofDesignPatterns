using MementoPattern;

var textEditor = new TextEditor(new Document("Test Name 1", "Test Text 1"));
var documentCareTaker = new DocumentCareTaker(textEditor);
documentCareTaker.Backup();
textEditor.ModifyDocument("Test Name 2", "Test Text 2");
documentCareTaker.Backup();
textEditor.ModifyDocument("Test Name 3", "Test Text 3");
documentCareTaker.Backup();
textEditor.ModifyDocument("Test Name 4", "Test Text 4");
documentCareTaker.Backup();
textEditor.ModifyDocument("Test Name 5", "Test Text 5");
documentCareTaker.Backup();
documentCareTaker.Restore(4);
documentCareTaker.Backup();
documentCareTaker.Restore(1);
documentCareTaker.PrintHistory();
textEditor.PrintCurrentDocument();