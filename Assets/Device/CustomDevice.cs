using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;
using MidiJack;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct CustomDeviceState : IInputStateTypeInfo
{
    public FourCC format => new FourCC('C', 'U', 'S', 'T');

    [InputControl(name = "note000", displayName = "Note C-1", layout = "Button", format = "BYTE", offset = 0, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note001", displayName = "Note C#-1", layout = "Button", format = "BYTE", offset = 1, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note002", displayName = "Note D-1", layout = "Button", format = "BYTE", offset = 2, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note003", displayName = "Note D#-1", layout = "Button", format = "BYTE", offset = 3, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note004", displayName = "Note E-1", layout = "Button", format = "BYTE", offset = 4, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note005", displayName = "Note F-1", layout = "Button", format = "BYTE", offset = 5, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note006", displayName = "Note F#-1", layout = "Button", format = "BYTE", offset = 6, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note007", displayName = "Note G-1", layout = "Button", format = "BYTE", offset = 7, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note008", displayName = "Note G#-1", layout = "Button", format = "BYTE", offset = 8, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note009", displayName = "Note A-1", layout = "Button", format = "BYTE", offset = 9, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note010", displayName = "Note A#-1", layout = "Button", format = "BYTE", offset = 10, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note011", displayName = "Note B-1", layout = "Button", format = "BYTE", offset = 11, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note012", displayName = "Note C0", layout = "Button", format = "BYTE", offset = 12, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note013", displayName = "Note C#0", layout = "Button", format = "BYTE", offset = 13, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note014", displayName = "Note D0", layout = "Button", format = "BYTE", offset = 14, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note015", displayName = "Note D#0", layout = "Button", format = "BYTE", offset = 15, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note016", displayName = "Note E0", layout = "Button", format = "BYTE", offset = 16, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note017", displayName = "Note F0", layout = "Button", format = "BYTE", offset = 17, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note018", displayName = "Note F#0", layout = "Button", format = "BYTE", offset = 18, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note019", displayName = "Note G0", layout = "Button", format = "BYTE", offset = 19, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note020", displayName = "Note G#0", layout = "Button", format = "BYTE", offset = 20, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note021", displayName = "Note A0", layout = "Button", format = "BYTE", offset = 21, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note022", displayName = "Note A#0", layout = "Button", format = "BYTE", offset = 22, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note023", displayName = "Note B0", layout = "Button", format = "BYTE", offset = 23, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note024", displayName = "Note C1", layout = "Button", format = "BYTE", offset = 24, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note025", displayName = "Note C#1", layout = "Button", format = "BYTE", offset = 25, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note026", displayName = "Note D1", layout = "Button", format = "BYTE", offset = 26, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note027", displayName = "Note D#1", layout = "Button", format = "BYTE", offset = 27, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note028", displayName = "Note E1", layout = "Button", format = "BYTE", offset = 28, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note029", displayName = "Note F1", layout = "Button", format = "BYTE", offset = 29, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note030", displayName = "Note F#1", layout = "Button", format = "BYTE", offset = 30, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note031", displayName = "Note G1", layout = "Button", format = "BYTE", offset = 31, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note032", displayName = "Note G#1", layout = "Button", format = "BYTE", offset = 32, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note033", displayName = "Note A1", layout = "Button", format = "BYTE", offset = 33, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note034", displayName = "Note A#1", layout = "Button", format = "BYTE", offset = 34, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note035", displayName = "Note B1", layout = "Button", format = "BYTE", offset = 35, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note036", displayName = "Note C2", layout = "Button", format = "BYTE", offset = 36, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note037", displayName = "Note C#2", layout = "Button", format = "BYTE", offset = 37, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note038", displayName = "Note D2", layout = "Button", format = "BYTE", offset = 38, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note039", displayName = "Note D#2", layout = "Button", format = "BYTE", offset = 39, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note040", displayName = "Note E2", layout = "Button", format = "BYTE", offset = 40, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note041", displayName = "Note F2", layout = "Button", format = "BYTE", offset = 41, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note042", displayName = "Note F#2", layout = "Button", format = "BYTE", offset = 42, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note043", displayName = "Note G2", layout = "Button", format = "BYTE", offset = 43, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note044", displayName = "Note G#2", layout = "Button", format = "BYTE", offset = 44, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note045", displayName = "Note A2", layout = "Button", format = "BYTE", offset = 45, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note046", displayName = "Note A#2", layout = "Button", format = "BYTE", offset = 46, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note047", displayName = "Note B2", layout = "Button", format = "BYTE", offset = 47, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note048", displayName = "Note C3", layout = "Button", format = "BYTE", offset = 48, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note049", displayName = "Note C#3", layout = "Button", format = "BYTE", offset = 49, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note050", displayName = "Note D3", layout = "Button", format = "BYTE", offset = 50, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note051", displayName = "Note D#3", layout = "Button", format = "BYTE", offset = 51, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note052", displayName = "Note E3", layout = "Button", format = "BYTE", offset = 52, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note053", displayName = "Note F3", layout = "Button", format = "BYTE", offset = 53, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note054", displayName = "Note F#3", layout = "Button", format = "BYTE", offset = 54, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note055", displayName = "Note G3", layout = "Button", format = "BYTE", offset = 55, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note056", displayName = "Note G#3", layout = "Button", format = "BYTE", offset = 56, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note057", displayName = "Note A3", layout = "Button", format = "BYTE", offset = 57, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note058", displayName = "Note A#3", layout = "Button", format = "BYTE", offset = 58, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note059", displayName = "Note B3", layout = "Button", format = "BYTE", offset = 59, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note060", displayName = "Note C4", layout = "Button", format = "BYTE", offset = 60, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note061", displayName = "Note C#4", layout = "Button", format = "BYTE", offset = 61, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note062", displayName = "Note D4", layout = "Button", format = "BYTE", offset = 62, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note063", displayName = "Note D#4", layout = "Button", format = "BYTE", offset = 63, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note064", displayName = "Note E4", layout = "Button", format = "BYTE", offset = 64, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note065", displayName = "Note F4", layout = "Button", format = "BYTE", offset = 65, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note066", displayName = "Note F#4", layout = "Button", format = "BYTE", offset = 66, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note067", displayName = "Note G4", layout = "Button", format = "BYTE", offset = 67, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note068", displayName = "Note G#4", layout = "Button", format = "BYTE", offset = 68, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note069", displayName = "Note A4", layout = "Button", format = "BYTE", offset = 69, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note070", displayName = "Note A#4", layout = "Button", format = "BYTE", offset = 70, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note071", displayName = "Note B4", layout = "Button", format = "BYTE", offset = 71, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note072", displayName = "Note C5", layout = "Button", format = "BYTE", offset = 72, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note073", displayName = "Note C#5", layout = "Button", format = "BYTE", offset = 73, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note074", displayName = "Note D5", layout = "Button", format = "BYTE", offset = 74, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note075", displayName = "Note D#5", layout = "Button", format = "BYTE", offset = 75, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note076", displayName = "Note E5", layout = "Button", format = "BYTE", offset = 76, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note077", displayName = "Note F5", layout = "Button", format = "BYTE", offset = 77, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note078", displayName = "Note F#5", layout = "Button", format = "BYTE", offset = 78, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note079", displayName = "Note G5", layout = "Button", format = "BYTE", offset = 79, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note080", displayName = "Note G#5", layout = "Button", format = "BYTE", offset = 80, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note081", displayName = "Note A5", layout = "Button", format = "BYTE", offset = 81, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note082", displayName = "Note A#5", layout = "Button", format = "BYTE", offset = 82, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note083", displayName = "Note B5", layout = "Button", format = "BYTE", offset = 83, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note084", displayName = "Note C6", layout = "Button", format = "BYTE", offset = 84, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note085", displayName = "Note C#6", layout = "Button", format = "BYTE", offset = 85, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note086", displayName = "Note D6", layout = "Button", format = "BYTE", offset = 86, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note087", displayName = "Note D#6", layout = "Button", format = "BYTE", offset = 87, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note088", displayName = "Note E6", layout = "Button", format = "BYTE", offset = 88, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note089", displayName = "Note F6", layout = "Button", format = "BYTE", offset = 89, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note090", displayName = "Note F#6", layout = "Button", format = "BYTE", offset = 90, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note091", displayName = "Note G6", layout = "Button", format = "BYTE", offset = 91, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note092", displayName = "Note G#6", layout = "Button", format = "BYTE", offset = 92, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note093", displayName = "Note A6", layout = "Button", format = "BYTE", offset = 93, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note094", displayName = "Note A#6", layout = "Button", format = "BYTE", offset = 94, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note095", displayName = "Note B6", layout = "Button", format = "BYTE", offset = 95, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note096", displayName = "Note C7", layout = "Button", format = "BYTE", offset = 96, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note097", displayName = "Note C#7", layout = "Button", format = "BYTE", offset = 97, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note098", displayName = "Note D7", layout = "Button", format = "BYTE", offset = 98, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note099", displayName = "Note D#7", layout = "Button", format = "BYTE", offset = 99, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note100", displayName = "Note E7", layout = "Button", format = "BYTE", offset = 100, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note101", displayName = "Note F7", layout = "Button", format = "BYTE", offset = 101, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note102", displayName = "Note F#7", layout = "Button", format = "BYTE", offset = 102, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note103", displayName = "Note G7", layout = "Button", format = "BYTE", offset = 103, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note104", displayName = "Note G#7", layout = "Button", format = "BYTE", offset = 104, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note105", displayName = "Note A7", layout = "Button", format = "BYTE", offset = 105, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note106", displayName = "Note A#7", layout = "Button", format = "BYTE", offset = 106, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note107", displayName = "Note B7", layout = "Button", format = "BYTE", offset = 107, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note108", displayName = "Note C8", layout = "Button", format = "BYTE", offset = 108, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note109", displayName = "Note C#8", layout = "Button", format = "BYTE", offset = 109, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note110", displayName = "Note D8", layout = "Button", format = "BYTE", offset = 110, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note111", displayName = "Note D#8", layout = "Button", format = "BYTE", offset = 111, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note112", displayName = "Note E8", layout = "Button", format = "BYTE", offset = 112, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note113", displayName = "Note F8", layout = "Button", format = "BYTE", offset = 113, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note114", displayName = "Note F#8", layout = "Button", format = "BYTE", offset = 114, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note115", displayName = "Note G8", layout = "Button", format = "BYTE", offset = 115, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note116", displayName = "Note G#8", layout = "Button", format = "BYTE", offset = 116, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note117", displayName = "Note A8", layout = "Button", format = "BYTE", offset = 117, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note118", displayName = "Note A#8", layout = "Button", format = "BYTE", offset = 118, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note119", displayName = "Note B8", layout = "Button", format = "BYTE", offset = 119, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note120", displayName = "Note C9", layout = "Button", format = "BYTE", offset = 120, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note121", displayName = "Note C#9", layout = "Button", format = "BYTE", offset = 121, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note122", displayName = "Note D9", layout = "Button", format = "BYTE", offset = 122, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note123", displayName = "Note D#9", layout = "Button", format = "BYTE", offset = 123, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note124", displayName = "Note E9", layout = "Button", format = "BYTE", offset = 124, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note125", displayName = "Note F9", layout = "Button", format = "BYTE", offset = 125, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note126", displayName = "Note F#9", layout = "Button", format = "BYTE", offset = 126, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "note127", displayName = "Note G9", layout = "Button", format = "BYTE", offset = 127, parameters = "normalize,normalizeMax=0.49803921568")]
    public fixed byte notes[128];

    [InputControl(name = "control000", displayName = "Control 0", layout = "Axis", format = "BYTE", offset = 128, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control001", displayName = "Control 1", layout = "Axis", format = "BYTE", offset = 129, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control002", displayName = "Control 2", layout = "Axis", format = "BYTE", offset = 130, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control003", displayName = "Control 3", layout = "Axis", format = "BYTE", offset = 131, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control004", displayName = "Control 4", layout = "Axis", format = "BYTE", offset = 132, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control005", displayName = "Control 5", layout = "Axis", format = "BYTE", offset = 133, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control006", displayName = "Control 6", layout = "Axis", format = "BYTE", offset = 134, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control007", displayName = "Control 7", layout = "Axis", format = "BYTE", offset = 135, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control008", displayName = "Control 8", layout = "Axis", format = "BYTE", offset = 136, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control009", displayName = "Control 9", layout = "Axis", format = "BYTE", offset = 137, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control010", displayName = "Control 10", layout = "Axis", format = "BYTE", offset = 138, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control011", displayName = "Control 11", layout = "Axis", format = "BYTE", offset = 139, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control012", displayName = "Control 12", layout = "Axis", format = "BYTE", offset = 140, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control013", displayName = "Control 13", layout = "Axis", format = "BYTE", offset = 141, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control014", displayName = "Control 14", layout = "Axis", format = "BYTE", offset = 142, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control015", displayName = "Control 15", layout = "Axis", format = "BYTE", offset = 143, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control016", displayName = "Control 16", layout = "Axis", format = "BYTE", offset = 144, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control017", displayName = "Control 17", layout = "Axis", format = "BYTE", offset = 145, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control018", displayName = "Control 18", layout = "Axis", format = "BYTE", offset = 146, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control019", displayName = "Control 19", layout = "Axis", format = "BYTE", offset = 147, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control020", displayName = "Control 20", layout = "Axis", format = "BYTE", offset = 148, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control021", displayName = "Control 21", layout = "Axis", format = "BYTE", offset = 149, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control022", displayName = "Control 22", layout = "Axis", format = "BYTE", offset = 150, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control023", displayName = "Control 23", layout = "Axis", format = "BYTE", offset = 151, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control024", displayName = "Control 24", layout = "Axis", format = "BYTE", offset = 152, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control025", displayName = "Control 25", layout = "Axis", format = "BYTE", offset = 153, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control026", displayName = "Control 26", layout = "Axis", format = "BYTE", offset = 154, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control027", displayName = "Control 27", layout = "Axis", format = "BYTE", offset = 155, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control028", displayName = "Control 28", layout = "Axis", format = "BYTE", offset = 156, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control029", displayName = "Control 29", layout = "Axis", format = "BYTE", offset = 157, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control030", displayName = "Control 30", layout = "Axis", format = "BYTE", offset = 158, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control031", displayName = "Control 31", layout = "Axis", format = "BYTE", offset = 159, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control032", displayName = "Control 32", layout = "Axis", format = "BYTE", offset = 160, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control033", displayName = "Control 33", layout = "Axis", format = "BYTE", offset = 161, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control034", displayName = "Control 34", layout = "Axis", format = "BYTE", offset = 162, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control035", displayName = "Control 35", layout = "Axis", format = "BYTE", offset = 163, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control036", displayName = "Control 36", layout = "Axis", format = "BYTE", offset = 164, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control037", displayName = "Control 37", layout = "Axis", format = "BYTE", offset = 165, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control038", displayName = "Control 38", layout = "Axis", format = "BYTE", offset = 166, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control039", displayName = "Control 39", layout = "Axis", format = "BYTE", offset = 167, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control040", displayName = "Control 40", layout = "Axis", format = "BYTE", offset = 168, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control041", displayName = "Control 41", layout = "Axis", format = "BYTE", offset = 169, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control042", displayName = "Control 42", layout = "Axis", format = "BYTE", offset = 170, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control043", displayName = "Control 43", layout = "Axis", format = "BYTE", offset = 171, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control044", displayName = "Control 44", layout = "Axis", format = "BYTE", offset = 172, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control045", displayName = "Control 45", layout = "Axis", format = "BYTE", offset = 173, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control046", displayName = "Control 46", layout = "Axis", format = "BYTE", offset = 174, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control047", displayName = "Control 47", layout = "Axis", format = "BYTE", offset = 175, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control048", displayName = "Control 48", layout = "Axis", format = "BYTE", offset = 176, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control049", displayName = "Control 49", layout = "Axis", format = "BYTE", offset = 177, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control050", displayName = "Control 50", layout = "Axis", format = "BYTE", offset = 178, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control051", displayName = "Control 51", layout = "Axis", format = "BYTE", offset = 179, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control052", displayName = "Control 52", layout = "Axis", format = "BYTE", offset = 180, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control053", displayName = "Control 53", layout = "Axis", format = "BYTE", offset = 181, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control054", displayName = "Control 54", layout = "Axis", format = "BYTE", offset = 182, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control055", displayName = "Control 55", layout = "Axis", format = "BYTE", offset = 183, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control056", displayName = "Control 56", layout = "Axis", format = "BYTE", offset = 184, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control057", displayName = "Control 57", layout = "Axis", format = "BYTE", offset = 185, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control058", displayName = "Control 58", layout = "Axis", format = "BYTE", offset = 186, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control059", displayName = "Control 59", layout = "Axis", format = "BYTE", offset = 187, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control060", displayName = "Control 60", layout = "Axis", format = "BYTE", offset = 188, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control061", displayName = "Control 61", layout = "Axis", format = "BYTE", offset = 189, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control062", displayName = "Control 62", layout = "Axis", format = "BYTE", offset = 190, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control063", displayName = "Control 63", layout = "Axis", format = "BYTE", offset = 191, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control064", displayName = "Control 64", layout = "Axis", format = "BYTE", offset = 192, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control065", displayName = "Control 65", layout = "Axis", format = "BYTE", offset = 193, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control066", displayName = "Control 66", layout = "Axis", format = "BYTE", offset = 194, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control067", displayName = "Control 67", layout = "Axis", format = "BYTE", offset = 195, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control068", displayName = "Control 68", layout = "Axis", format = "BYTE", offset = 196, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control069", displayName = "Control 69", layout = "Axis", format = "BYTE", offset = 197, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control070", displayName = "Control 70", layout = "Axis", format = "BYTE", offset = 198, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control071", displayName = "Control 71", layout = "Axis", format = "BYTE", offset = 199, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control072", displayName = "Control 72", layout = "Axis", format = "BYTE", offset = 200, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control073", displayName = "Control 73", layout = "Axis", format = "BYTE", offset = 201, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control074", displayName = "Control 74", layout = "Axis", format = "BYTE", offset = 202, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control075", displayName = "Control 75", layout = "Axis", format = "BYTE", offset = 203, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control076", displayName = "Control 76", layout = "Axis", format = "BYTE", offset = 204, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control077", displayName = "Control 77", layout = "Axis", format = "BYTE", offset = 205, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control078", displayName = "Control 78", layout = "Axis", format = "BYTE", offset = 206, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control079", displayName = "Control 79", layout = "Axis", format = "BYTE", offset = 207, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control080", displayName = "Control 80", layout = "Axis", format = "BYTE", offset = 208, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control081", displayName = "Control 81", layout = "Axis", format = "BYTE", offset = 209, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control082", displayName = "Control 82", layout = "Axis", format = "BYTE", offset = 210, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control083", displayName = "Control 83", layout = "Axis", format = "BYTE", offset = 211, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control084", displayName = "Control 84", layout = "Axis", format = "BYTE", offset = 212, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control085", displayName = "Control 85", layout = "Axis", format = "BYTE", offset = 213, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control086", displayName = "Control 86", layout = "Axis", format = "BYTE", offset = 214, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control087", displayName = "Control 87", layout = "Axis", format = "BYTE", offset = 215, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control088", displayName = "Control 88", layout = "Axis", format = "BYTE", offset = 216, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control089", displayName = "Control 89", layout = "Axis", format = "BYTE", offset = 217, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control090", displayName = "Control 90", layout = "Axis", format = "BYTE", offset = 218, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control091", displayName = "Control 91", layout = "Axis", format = "BYTE", offset = 219, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control092", displayName = "Control 92", layout = "Axis", format = "BYTE", offset = 220, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control093", displayName = "Control 93", layout = "Axis", format = "BYTE", offset = 221, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control094", displayName = "Control 94", layout = "Axis", format = "BYTE", offset = 222, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control095", displayName = "Control 95", layout = "Axis", format = "BYTE", offset = 223, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control096", displayName = "Control 96", layout = "Axis", format = "BYTE", offset = 224, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control097", displayName = "Control 97", layout = "Axis", format = "BYTE", offset = 225, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control098", displayName = "Control 98", layout = "Axis", format = "BYTE", offset = 226, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control099", displayName = "Control 99", layout = "Axis", format = "BYTE", offset = 227, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control100", displayName = "Control 100", layout = "Axis", format = "BYTE", offset = 228, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control101", displayName = "Control 101", layout = "Axis", format = "BYTE", offset = 229, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control102", displayName = "Control 102", layout = "Axis", format = "BYTE", offset = 230, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control103", displayName = "Control 103", layout = "Axis", format = "BYTE", offset = 231, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control104", displayName = "Control 104", layout = "Axis", format = "BYTE", offset = 232, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control105", displayName = "Control 105", layout = "Axis", format = "BYTE", offset = 233, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control106", displayName = "Control 106", layout = "Axis", format = "BYTE", offset = 234, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control107", displayName = "Control 107", layout = "Axis", format = "BYTE", offset = 235, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control108", displayName = "Control 108", layout = "Axis", format = "BYTE", offset = 236, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control109", displayName = "Control 109", layout = "Axis", format = "BYTE", offset = 237, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control110", displayName = "Control 110", layout = "Axis", format = "BYTE", offset = 238, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control111", displayName = "Control 111", layout = "Axis", format = "BYTE", offset = 239, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control112", displayName = "Control 112", layout = "Axis", format = "BYTE", offset = 240, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control113", displayName = "Control 113", layout = "Axis", format = "BYTE", offset = 241, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control114", displayName = "Control 114", layout = "Axis", format = "BYTE", offset = 242, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control115", displayName = "Control 115", layout = "Axis", format = "BYTE", offset = 243, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control116", displayName = "Control 116", layout = "Axis", format = "BYTE", offset = 244, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control117", displayName = "Control 117", layout = "Axis", format = "BYTE", offset = 245, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control118", displayName = "Control 118", layout = "Axis", format = "BYTE", offset = 246, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control119", displayName = "Control 119", layout = "Axis", format = "BYTE", offset = 247, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control120", displayName = "Control 120", layout = "Axis", format = "BYTE", offset = 248, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control121", displayName = "Control 121", layout = "Axis", format = "BYTE", offset = 249, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control122", displayName = "Control 122", layout = "Axis", format = "BYTE", offset = 250, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control123", displayName = "Control 123", layout = "Axis", format = "BYTE", offset = 251, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control124", displayName = "Control 124", layout = "Axis", format = "BYTE", offset = 252, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control125", displayName = "Control 125", layout = "Axis", format = "BYTE", offset = 253, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control126", displayName = "Control 126", layout = "Axis", format = "BYTE", offset = 254, parameters = "normalize,normalizeMax=0.49803921568")]
    [InputControl(name = "control127", displayName = "Control 127", layout = "Axis", format = "BYTE", offset = 255, parameters = "normalize,normalizeMax=0.49803921568")]
    public fixed byte controls[128];
}

#if UNITY_EDITOR
[UnityEditor.InitializeOnLoad]
#endif
[InputControlLayout(stateType = typeof(CustomDeviceState))]
public class CustomDevice : InputDevice, IInputUpdateCallbackReceiver
{
    #if UNITY_EDITOR

    static CustomDevice()
    {
        Initialize();
    }

    #endif

    [UnityEngine.RuntimeInitializeOnLoadMethod]
    private static void Initialize()
    {
        InputSystem.RegisterLayout<CustomDevice>(
            matches: new InputDeviceMatcher().WithInterface("Custom"));
    }

    ButtonControl [] _notes;
    AxisControl [] _controls;
    CustomDeviceState _state;
    bool _modified;

    public ButtonControl GetNote(int index)
    {
        return _notes[index];
    }

    public AxisControl GetControl(int index)
    {
        return _controls[index];
    }

    protected override void FinishSetup()
    {
        base.FinishSetup();

        MidiMaster.noteOnDelegate += OnNoteOn;
        MidiMaster.noteOffDelegate += OnNoteOff;
        MidiMaster.knobDelegate += OnKnob;

        _notes = new ButtonControl[128];
        _controls = new AxisControl[128];

        for (var i = 0; i < 128; i++)
        {
            _notes[i] = GetChildControl<ButtonControl>("note" + i.ToString("D3"));
            _controls[i] = GetChildControl<AxisControl>("control" + i.ToString("D3"));
        }
    }

    public static CustomDevice current { get; private set; }

    public override void MakeCurrent()
    {
        base.MakeCurrent();
        current = this;
    }

    protected override void OnRemoved()
    {
        base.OnRemoved();
        if (current == this) current = null;
    }

    void OnNoteOn(MidiChannel channel, int note, float velocity)
    {
        unsafe { _state.notes[note] = (byte)(velocity * 127); }
        InputSystem.QueueDeltaStateEvent(_notes[note], (byte)(velocity * 127));
    }

    void OnNoteOff(MidiChannel channel, int note)
    {
        unsafe { _state.notes[note] = 0; }
        InputSystem.QueueDeltaStateEvent(_notes[note], (byte)0);
    }

    void OnKnob(MidiChannel channel, int knobNumber, float knobValue)
    {
        unsafe { _state.controls[knobNumber] = (byte)(knobValue * 127); }
        _modified = true;
    }

    #if UNITY_EDITOR

    [UnityEditor.MenuItem("Tools/Custom Device Sample/Create Device")]
    private static void CreateDevice()
    {
        InputSystem.AddDevice(new InputDeviceDescription
        {
            interfaceName = "Custom",
            product = "Sample Product"
        });
    }

    [UnityEditor.MenuItem("Tools/Custom Device Sample/Remove Device")]
    private static void RemoveDevice()
    {
        var customDevice = InputSystem.devices.FirstOrDefault(x => x is CustomDevice);
        if (customDevice != null)
            InputSystem.RemoveDevice(customDevice);
    }

    public void OnUpdate()
    {
        if (_modified)
        {
            InputSystem.QueueStateEvent(this, _state);
            _modified = false;
        }
    }

    #endif
}
