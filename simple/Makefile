#!/usr/bin/make

SOURCES=Program.cs
REFERENCES=-r:System.Xml.Linq.dll

all: bin/hello.exe

clean:
	rm -rf bin

bin/hello.exe: $(SOURCES)
	mkdir -p bin
	csc $(REFERENCES) $(SOURCES) -out:bin/hello.exe

run: bin/hello.exe
	mono bin/hello.exe




.PHONY: run all
