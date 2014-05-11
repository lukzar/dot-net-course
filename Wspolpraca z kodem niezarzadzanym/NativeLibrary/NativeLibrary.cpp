#include "stdafx.h"

#include "NativeLibrary.h"

int Execute(int n, int (*f)(int)) {
    return f(n);
}
