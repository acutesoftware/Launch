#Launch
####...for when Windows Task Schedular just refuses to run a Python script
<br />


1. Using Visual Studio 2008 or later, compile Module1.vb to an exe (Launch.exe)<br /><br />

2. Edit the Launch.cfg file to call a Batch file<br />
      d:\py\_djm\DAILY.BAT<br />
<br />
3. Edit the Batch file (e.g. DAILY.BAT) to call a Python script<br />
      start C:\Python27\Python.exe D:\py\_djm\daily_python_tasks.py<br />
<br />
<br />