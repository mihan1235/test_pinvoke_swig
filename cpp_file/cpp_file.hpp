#pragma once


#ifdef CPP_EXPORTS
#define CPP_API __declspec(dllexport)
#else
#define CPP_API __declspec(dllimport)
#endif

class CPP_API cpp
{
public:
	cpp(void);
	~cpp(void);

	int times2(int arg);
};