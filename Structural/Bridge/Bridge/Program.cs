
using Bridge;

WindowAbstract window = new WindowDialog(new WindowWindows());
window.draw();

window = new WindowDialog(new WindowLinux());
window.draw();
