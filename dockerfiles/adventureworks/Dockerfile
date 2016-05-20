FROM library/postgres

ENV POSTGRES_USER awuser
ENV POSTGRES_PASSWORD redhat
ENV POSTGRES_DB adventureworks

ADD shifts.sql /docker-entrypoint-initdb.d/
ADD departments.sql /docker-entrypoint-initdb.d/
ADD employees.sql /docker-entrypoint-initdb.d/
ADD employee-department-history.sql /docker-entrypoint-initdb.d/
ADD employee-pay-history.sql /docker-entrypoint-initdb.d/
ADD job-candidates.sql /docker-entrypoint-initdb.d/
