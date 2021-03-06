

//puedes modificar las propiedades
public struct Vector3
{
    public float x { get; set; }
    public float y { get; set; }
    public float z { get; set; }

    public override string ToString()
    {
        return "(" + x + ", " + y + ", " + z + ")";
    }
}

//no puedes modificar los campos
public struct Vector3
{
    public float x;
    public float y;
    public float z;

    public override string ToString()
    {
        return "(" + x + ", " + y + ", " + z + ")";
    }
}
