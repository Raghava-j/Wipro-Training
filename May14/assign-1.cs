using System;
interface IMusicPlayer
{
    void Play(string song);
    void Pause();
    void Stop();
}
class SpotifyPlayer : IMusicPlayer
{
    public void Play(string song)
    {
        Console.WriteLine($"Playing {song} on Spotify");
    }
    public void Pause()
    {
        Console.WriteLine("Spotify playback paused");
    }
    public void Stop()
    {
        Console.WriteLine("Spotify playback stopped");
    }

}
class AppleMusicPlayer : IMusicPlayer
{
    public void Play(string song)
    {
        Console.WriteLine($"Playing {song} on Apple Music");
    }
    public void Pause()
    {
        Console.WriteLine($"Apple Music playback paused");
    }
    public void Stop()
    {
        Console.WriteLine($"Apple Music playback stopped");
    }
}
class Program
{
    static void Main()
    {
        IMusicPlayer spotify = new SpotifyPlayer();
        IMusicPlayer appleMusic = new AppleMusicPlayer();

        Console.WriteLine("Spotify Player");
        spotify.Play("Blinding Lights");
        spotify.Pause();
        spotify.Stop();

        Console.WriteLine("AppleMusic Player");
        appleMusic.Play("Shape of You");
        appleMusic.Pause();
        appleMusic.Stop();
    }
}