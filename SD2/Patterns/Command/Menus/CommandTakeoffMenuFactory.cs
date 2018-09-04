using SD2.Patterns.Command.State;
using SD2.Patterns.Command.UndoTakeoffOperations;
using SD2.SharedFeatures.Informationals;
using SD2.SharedFeatures.Menus;

namespace SD2.Patterns.Command.Menus
{
    public static class CommandTakeoffMenuFactory
    {
        public static Menu<TakeoffDto> SetDrawingNumberMenu(TakeoffDto takeoffState) => new SetDrawingNumberMenu(takeoffState);
        public static Menu<TakeoffDto> SetAbbreviationMenu(TakeoffDto takeoffState) => new SetAbbreviationMenu(takeoffState);
        public static Menu<TakeoffDto> SetSizeMenu(TakeoffDto takeoffState) => new SetSizeMenu(takeoffState);

        public static Menu AddTakeoffMenu => new AddTakeoffMenu();
        public static Menu<TakeoffPutDto> EditTakeoffMenu(TakeoffPutDto takeoffPutDto) => new EditTakeoffMenu(takeoffPutDto);
        
        public static Menu<Takeoff, Takeoff> SelectTakeoffByIdMenu(Takeoff takeoff) => new SelectTakeoffByIdMenu(takeoff);

        public static Informational<UndoableCommandState> DisplayAllTakeoffsInformational =>new DisplayAllTakeoffsInformational();
    }
}
