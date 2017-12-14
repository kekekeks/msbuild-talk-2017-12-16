#!/bin/sh
set -xe

rm -f hello.exe
csc -r:System.Xml.Linq.dll -out:hello.exe Program.cs 
