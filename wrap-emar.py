#!/usr/bin/env python
import sys
fileName = sys.path[0] + '/upstream/emscripten/cmake/Modules/Platform/Emscripten.cmake'
with open(fileName) as f:
    newText = f.read().replace('${EMSCRIPTEN_ROOT_PATH}/emar${EMCC_SUFFIX}', '${EMSCRIPTEN_ROOT_PATH}/emar.exe')
with open(fileName, "w") as f:
    f.write(newText)
