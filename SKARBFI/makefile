CXX=g++
RM=rm -f
CPPFLAGS=-g -pthread
LDFLAGS=-g
LDLIBS=-W 

SOURCES=main.cpp
OBJECTS=$(subst .cpp,.o,$(SOURCES))

all: main

main : $(OBJECTS)
	$(CXX) $(LDFLAGS) -o main $(OBJECTS) $(LDLIBS)

main.o : main.cpp 

clean : 
	$(RM) $(OBJECTS)


