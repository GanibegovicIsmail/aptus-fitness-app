namespace Aptus.Models;

public class Exercise : ContentPage
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }
    public double Weight { get; set; }
    public string MuscleGroup { get; set; }
}