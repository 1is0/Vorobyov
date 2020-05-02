// ---------------------------------------------------------------------------

#pragma hdrstop

#include "Data.h"
// ---------------------------------------------------------------------------
#pragma package(smart_init)

Data::Data(AnsiString t, int k) : name(t), num(k), left(nullptr), right(nullptr) {}
