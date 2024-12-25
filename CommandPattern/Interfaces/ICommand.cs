﻿namespace CommandPattern.Interfaces;

public interface ICommand
{
    public void Execute();
    public void Undo();
}