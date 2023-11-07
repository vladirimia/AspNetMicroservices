﻿namespace EventBus.Messages.Events;

public class IntegrationBaseEvent
{
    public IntegrationBaseEvent()
    {
        Id = Guid.NewGuid();
        CreationDate = DateTime.UtcNow;
    }

    public Guid Id { get; private set; }

    public IntegrationBaseEvent(Guid id, DateTime creationDate)
    {
        Id = id;
        CreationDate = creationDate;
    }

    public DateTime CreationDate { get; private set; }
}
