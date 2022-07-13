namespace ModelHelper;

public abstract class Model
{
    protected const int NameMax = 70;
    protected const int DescriptionMax = 280;
    protected const int PathMax = 260;

    protected const string Datetime2Name = "datetime2";

    protected const double DoubleMax = 1000000;
    
    protected const string IdError = "Id must be greater than zero";

    protected static readonly IDictionary<Field, MaxLength> MaxLength;

    static Model()
    {
        MaxLength = new Dictionary<Field, MaxLength>();
        SetMaxLengthData();
    }

    private static void SetMaxLengthData()
    {
        MaxLength.Add(
            Field.Name
            , new MaxLength(
                Field.Name.ToString()
                , "UK Government Data Standards Catalogue suggests 70 characters for a single field to hold the Full Name"
                , NameMax));
        MaxLength.Add(
            Field.Description
            , new MaxLength(
                Field.Description.ToString()
                , "2017 Twitter character limit of 280 characters"
                , DescriptionMax));
        MaxLength.Add(
            Field.Path
            , new MaxLength(
                Field.Path.ToString()
                , "Windows file system imposes a default restriction on the maximum path length of 260 characters for folder/filename"
                , PathMax));
    }
}