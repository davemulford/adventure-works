CREATE TABLE shift (
	ShiftID SERIAL NOT NULL CONSTRAINT PK_Shift PRIMARY KEY,
	Name VARCHAR(50) NOT NULL,
	StartTime TIME NOT NULL,
	EndTime TIME NOT NULL,
	ModifiedDate TIMESTAMP NOT NULL
);

INSERT INTO shift (ShiftID, Name, StartTime, EndTime, ModifiedDate) VALUES (1, N'Day', '07:00:00'::TIME, '15:00:00'::TIME, '2008-04-30T00:00:00.000'::TIMESTAMP);
INSERT INTO shift (ShiftID, Name, StartTime, EndTime, ModifiedDate) VALUES (2, N'Evening', '15:00:00'::TIME, '23:00:00'::TIME, '2008-04-30T00:00:00.000'::TIMESTAMP);
INSERT INTO shift (ShiftID, Name, StartTime, EndTime, ModifiedDate) VALUES (3, N'Night', '23:00:00'::TIME, '07:00:00'::TIME, '2008-04-30T00:00:00.000'::TIMESTAMP);

SELECT setval('shift_shiftid_seq'::regclass, 3);
