// NativeLibrary.h

#pragma once

extern "C" {
   __declspec(dllexport) int Execute(int number, int (*)(int));
}

