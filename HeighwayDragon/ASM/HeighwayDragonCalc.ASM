format PE GUI 4.0 DLL
include 'win32a.inc'

section '.text' code readable executable


;x' = -0.4 * x - 1
proc CalcX1 stdcall, x:dword, xMultiplier:dword, c:dword, result:dword
	finit
	mov ebx,[xMultiplier]
	fld dword [ebx]
	mov ebx,[x]
	fld dword [ebx]
	fmulp
	mov ebx,[c]
	fld dword [ebx]
	fsubp
	mov ebx,[result]
	fstp dword [ebx]
	ret
endp

;y' = -0.4 * y + 0.1
proc CalcY1 stdcall, y:dword,yMultiplier:dword, c:dword, result:dword
	finit
	mov ebx,[yMultiplier]
	fld dword [ebx]
	mov ebx,[y]
	fld dword [ebx]
	fmulp
	mov ebx,[c]
	fld dword [ebx]
	faddp
	mov ebx,[result]
	fstp dword [ebx]
	ret
endp

;x' = 0.76 * x - 0.4 * y
proc CalcX2 stdcall, x:dword, y:dword, xMultiplier:dword, yMultiplier:dword, result:dword
	finit
	mov ebx,[xMultiplier]
	fld dword [ebx]
	mov ebx,[x]
	fld dword [ebx]
	fmulp
	mov ebx,[yMultiplier]
	fld dword [ebx]
	mov ebx,[y]
	fld dword [ebx]
	fmulp
	fsubp
	mov ebx,[result]
	fstp dword [ebx]
	ret
endp

;y' = 0.4 * x + 0.76 * y
proc CalcY2 stdcall, x:dword, y:dword, xMultiplier:dword, yMultiplier:dword, result:dword
	finit
	mov ebx,[xMultiplier]
	fld dword [ebx]
	mov ebx,[x]
	fld dword [ebx]
	fmulp
	mov ebx,[yMultiplier]
	fld dword [ebx]
	mov ebx,[y]
	fld dword [ebx]
	fmulp
	faddp
	mov ebx,[result]
	fstp dword [ebx]
	ret
endp

proc dllOK stdcall
	invoke MessageBoxA, HWND_DESKTOP,_tresc,_tytul, MB_OK
	ret
endp


section '.data' data readable writeable
	   _tytul db "Dragon calc check", 0
	   _tresc db "It works!", 0
	   zm1	dw 1

section '.idata' import data readable writeable
 library user32,'USER32.DLL'
 import  user32,\
   MessageBoxA,'MessageBoxA'


section '.edata' export data readable

  export 'MojaDLL.DLL',\
	 dllOK,'dllOK',\
	 CalcX1,'CalcX1',\
	 CalcY1,'CalcY1',\
	 CalcX2,'CalcX2',\
	 CalcY2,'CalcY2'


section '.reloc' fixups data readable discardable