namespace SharpPDFLabel.Labels.LetterLabels.Avery
{
    public class L5160 : LabelDefinition
    {
        // all sizes are in mm
        public L5160()
        {
            _Width = 66.802;
            _Height = 25.4;
            _HorizontalGapWidth = 3.048;
            _VerticalGapHeight = 0;

            _PageMarginTop = 12.7;
            _PageMarginBottom = 12.7;
            _PageMarginLeft = 4.826;
            _PageMarginRight = 4.826;

            PageSize = Enums.PageSize.LETTER;
            LabelsPerRow = 3;
            LabelRowsPerPage = 10;
        }
    }
}
