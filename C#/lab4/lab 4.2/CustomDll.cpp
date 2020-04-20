#include "pch.h"
#include <math.h>

#define DLL_DOUBLE_EXPORTS extern "C" __declspec(dllexport) double

DLL_DOUBLE_EXPORTS __stdcall perimetr(double a, double b)
{
	return (a + b) * 2;
}

DLL_DOUBLE_EXPORTS __cdecl square(double a, double b)
{
	return (a * b);
}

DLL_DOUBLE_EXPORTS __stdcall diagonal(double a, double b)
{
	return sqrt(a * a + b * b);
}