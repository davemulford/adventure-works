FROM library/postgres

ENV POSTGRES_USER awuser
ENV POSTGRES_PASSWORD redhat
ENV POSTGRES_DB adventureworks

ADD 01-shifts.sql /docker-entrypoint-initdb.d/
ADD 02-departments.sql /docker-entrypoint-initdb.d/
ADD 03-employees.sql /docker-entrypoint-initdb.d/
ADD 04-employee-department-history.sql /docker-entrypoint-initdb.d/
ADD 05-employee-pay-history.sql /docker-entrypoint-initdb.d/
