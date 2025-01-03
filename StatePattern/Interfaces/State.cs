﻿namespace StatePattern.Interfaces;

public interface State
{
    void InsertQuarter();
    void EjectQuarter();
    void TurnCrank();
    void Dispense();
    void Refill();
}