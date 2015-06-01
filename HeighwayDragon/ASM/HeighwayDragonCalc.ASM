format PE GUI 4.0 DLL
include 'win32a.inc'

section '.text' code readable executable

proc GetRandomNumber stdcall
	push ebx
	; TODO Random number
	pop ebx
	ret
endp

proc CalcX1 stdcall a:qword, b:qword
	push ebx
	; TODO X1 transform
	pop ebx
	ret
endp

proc CalcY1 stdcall a:qword, b:qword
	push ebx
	; TODO Y1 transform
	pop ebx
	ret
endp

proc CalcX2 stdcall a:qword, b:qword
	push ebx
	; TODO X2 transform
	pop ebx
	ret
endp

proc CalcY2 stdcall a:qword, b:qword
	push ebx
	; TODO Y2 transform
	pop ebx
	ret
endp

proc dllOK stdcall
	invoke MessageBoxA, HWND_DESKTOP,_tresc,_tytul, MB_OK
	ret
endp


section '.data' data readable writeable
	   _tytul db "Dragon calc check", 0
	   _tresc db "It works!", 0

section '.idata' import data readable writeable
 library user32,'USER32.DLL'
 import  user32,\
   MessageBoxA,'MessageBoxA'


section '.edata' export data readable

  export 'MojaDLL.DLL',\
	 dllOK,'dllOK',\
	 GetRandomNumber,'GetRandomNumber',\
	 CalcX1,'CalcX1',\
	 CalcY1,'CalcY1',\
	 CalcX2,'CalcX2',\
	 CalcY2,'CalcY2'
	 


section '.reloc' fixups data readable discardable