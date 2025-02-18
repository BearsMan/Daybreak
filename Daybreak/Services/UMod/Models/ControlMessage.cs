﻿namespace Daybreak.Services.UMod.Models;
internal enum ControlMessage : uint
{
    CONTROL_ADD_TEXTURE = 1,
    CONTROL_FORCE_RELOAD_TEXTURE = 2,
    CONTROL_REMOVE_TEXTURE = 3,
    CONTROL_FORCE_RELOAD_TEXTURE_DATA = 4,
    CONTROL_ADD_TEXTURE_DATA = 5,
    CONTROL_MORE_TEXTURES = 6,
    CONTROL_END_TEXTURES = 7,

    CONTROL_SAVE_ALL = 10,
    CONTROL_SAVE_SINGLE = 11,
    CONTROL_SHOW_STRING = 12,
    CONTROL_SHOW_TEXTURE = 13,
    CONTROL_SET_DIR = 14,
    CONTROL_KEY_BACK = 20,
    CONTROL_KEY_SAVE = 21,
    CONTROL_KEY_NEXT = 22,
    CONTROL_FONT_COLOUR = 30,
    CONTROL_TEXTURE_COLOUR = 31,
    CONTROL_WIDTH_FILTER = 40,
    CONTROL_HEIGHT_FILTER = 41,
    CONTROL_DEPTH_FILTER = 42,
    CONTROL_FORMAT_FILTER = 43,
    CONTROL_SAVE_FORMAT = 50,
    CONTROL_SUPPORT_TPF = 60,
    CONTROL_GAME_EXIT = 100,
    CONTROL_ADD_CLIENT = 101,
    CONTROL_REMOVE_CLIENT = 102
}
