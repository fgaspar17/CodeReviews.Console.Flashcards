﻿namespace FlashcardsLibrary;
public class StudySessionDto
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int Score { get; set; }
    public string? Stack { get; set; }
}