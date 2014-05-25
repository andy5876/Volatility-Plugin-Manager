Volatility-Plugin-Manager
=========================

GUI interface for Volatility
Allows the user to select multiple Volatility plugins to be run on a full image or specified PIDs.
Allows the user to specify an ouput directory for the plugins to place their output files and dump directories

Any questions, suggestions or comments please feel free to contact

**If you do not specify your own output directory VPM will default to creating the following directory:
C:\vol-plugin-ouptuts\

Progress Bar
------------


The Progress bar at the moment, is causing me some difficulty, it only updates once each plugin is completed. This means that if you chose a plugin that happens to take a while and this runs first, the progress bar will sit at 0% until it that first plugin is complete. 

I appreciate that this doesn't give you the warm and fuzzy feeling that the tool is working, and this is an issue I would like to fix. If there are any C#'ers out there that would like to suggest a fix to this I would be massively thankful.

Until such time as I fix it, I would encourage you to have a little faith that it is working despite it sitting at 0%
If you really want to make sure as it is taking a long time. Look in your output directory and you should see a file has been created. If not, then in task manager, you should see two instances of Volatility.exe in the background processes. One should be working away , the other should not. If you see this, then rest assured Volatility is churning away at your plugin.



Andy Nind
andrewnind@gmail.com


Supported Plugins:

Image Info,
psscan,
pslist,
pstree,
dlllist,
connscan,
sockscan,
connections and sockets,
netscan,
modscan,
cmdscan,
svcscan,
getsids,
evtlogs,
screenshot,
userassist,
shellbags,
shimcache,
sessions,
vadinfo,
vaddump,
memdump,
handles,
privs,
envars,
threads,
iehistory,
malfind,
atoms,
atomscan,
bioskbd,
callbacks,
consoles,
deskscan,
devicetree,
dlldump,
driverirp,
dumpcerts,
driverscan,
dumpfiles,
eventhooks,
filescan,
gahti,
gditimers,
gdt,
getservicesids,
hivelist,
hivescan,
idt,
kdbgscan,
kpcrscan,
ldrmodules,
mbrparser,
messagehooks,
mftparser,
modules,
mutantscan,
procexedump,
procmemdump,
psxview,
vadtree,
ssdt,
symlinkscan,
thrdscan,
timeliner,
timers,
unloadedmodules,
userhandles,
